import ConcordanceTokens from './ConcordanceTokens';

const ConcordanceDetailsParagraph = (props) => {
    return (
        <div>
            <ConcordanceTokens tokens={props.tokens} />
        </div>
    )
};

export default ConcordanceDetailsParagraph;