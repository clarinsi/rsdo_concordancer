import ConcordanceToken from "./ConcordanceToken";

const ConcordanceTokens = (props) => {
    return (
        <>
            {props.tokens.map((x,i) => <ConcordanceToken content={x.form} isCenterMatch={x.isCenterMatch} isWordInContextMatch={x.isWordInContextMatch} key={i} />)}
        </>
    );
};

export default ConcordanceTokens;